$(document).ready(function(){

        jQuery(".content_container").delegate(
          "#twitter-widget-0",
          "DOMSubtreeModified propertychange",
          function() {
            customizeTweetMedia();
          }
        );

        var customizeTweetMedia = function() {
          jQuery(".content_container")
            .find(".twitter-timeline")
            .contents()
            .find(".timeline-Tweet-media")
            .css("display", "none");
          jQuery(".content_container")
            .find(".twitter-timeline")
            .contents()
            .find(".timeline-Tweet")
            .css({
              border: "1.5px groove white",
              "border-radius": "15%",
              margin: "0.5em",
              color:"#EAE0CC"
            });
          //also call the function on dynamic updates in addition to page load
          jQuery(".content_container")
            .find(".twitter-timeline")
            .contents()
            .find(".timeline-TweetList")
            .bind("DOMSubtreeModified propertychange", function() {
              customizeTweetMedia(this);
            });
        };
});