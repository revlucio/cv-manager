$(function () {
    $('#addAchievement').on('click', function () {
        $.ajax({
            url: '/AddAchievement/',
            data: $('form').serializeArray(),
            type: 'POST',
            success: function (result) {
                $('#achievements').html(result);
            }
        });
    });

    $('#achievements').delegate('.removeA', 'click', function () {
        var index = $(this).data('val');

        $.ajax({
            url: '@Url.Action("RemoveAchievement", "Home")' + '/' + index,
            type: 'GET',
            success: function (result) {
                $('#achievements').html(result);
            }
        });
    });
});