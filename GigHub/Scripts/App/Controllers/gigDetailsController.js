var GigDetailsController = function (followingService) {
    var followButton;

    var init = function () {
        $(".js-toggle-follow").click(toggleFollow);
    }

    var toggleFollow = function (e) {
        followButton = $(e.target);

        var followeeId = followButton.attr("data-user-id");

        if (followButton.hasClass("btn-light"))
            followingService.createFollowing(followeeId, done, fail);
        else
            followingService.deleteFollowing(followeeId, done, fail);
    }

    var done = function () {
        var text = (followButton.text() == "Follow") ? "Following" : "Follow";
        followButton.toggleClass("btn-info").toggleClass("btn-light").text(text);
    }

    var fail = function () {
        alert("Something failed!");
    }

    return {
        init: init
    }

}(FollowingService);