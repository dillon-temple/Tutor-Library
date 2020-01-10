using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

using LandR.Helpers;
using LandR.Models;


namespace LandR.Controllers
{
    [Route("api/[controller]")]
    public class ImagesController : Controller
    {
        // make sure that appsettings.json is filled with the necessary details of the azure storage
        private readonly AzureStorageConfig storageConfig = null;
        private MyContext dbContext;

        public ImagesController(IOptions<AzureStorageConfig> config, MyContext context)
        {
            storageConfig = config.Value;
            dbContext = context;
        }

        // POST /api/images/upload
        [HttpPost("[action]")]
        public async Task<IActionResult> Upload(ICollection<IFormFile> files)
        {
            bool isUploaded = false;

            try
            {

                if (files.Count == 0)

                    return BadRequest("No files received from the upload");

                if (storageConfig.AccountKey == string.Empty || storageConfig.AccountName == string.Empty)

                    return BadRequest("sorry, can't retrieve your azure storage details from appsettings.js, make sure that you add azure storage details there");

                if (storageConfig.ImageContainer == string.Empty)

                    return BadRequest("Please provide a name for your image container in the azure blob storage");

                foreach (var formFile in files)
                {
                    if (StorageHelper.IsImage(formFile))
                    {
                        if (formFile.Length > 0)
                        {
                            using (Stream stream = formFile.OpenReadStream())
                            {
                                // Encode file name
                                string extension = Path.GetExtension(formFile.FileName);
                                string newFileName = DateTime.Now.Ticks + extension;
                                // Find DB User
                                var LoggedInUser = HttpContext.Session.GetInt32("Logged");
                                var userInDb = dbContext.Users.FirstOrDefault(u => u.UserId == LoggedInUser);
                                // Save fileName to DB
                                userInDb.ProfilePic = newFileName;
                                dbContext.Update(userInDb);
                                dbContext.SaveChanges();

                                isUploaded = await StorageHelper.UploadFileToStorage(stream, newFileName, storageConfig);
                            }
                        }
                    }
                    else
                    {
                        return new UnsupportedMediaTypeResult();
                    }
                }

                if (isUploaded)
                {
                    // if (storageConfig.ThumbnailContainer != string.Empty)

                    //     return new AcceptedAtActionResult("GetThumbNails", "Images", null, null);

                    // else

                        return RedirectToAction("MyProfile", "Home");
                }
                else

                    return BadRequest("Look like the image couldnt upload to the storage");


            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET /api/images/thumbnails
        [HttpGet("thumbnails")]
        public async Task<IActionResult> GetImages()
        {

            try
            {
                if (storageConfig.AccountKey == string.Empty || storageConfig.AccountName == string.Empty)

                    return BadRequest("sorry, can't retrieve your azure storage details from appsettings.js, make sure that you add azure storage details there");

                if (storageConfig.ImageContainer == string.Empty)

                    return BadRequest("Please provide a name for your image container in the azure blob storage");

                List<string> imageUrls = await StorageHelper.GetThumbNailUrls(storageConfig);
                return new ObjectResult(imageUrls);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

    }
}