function layoutViewModel() {
    var self = {};

    self.cultureData = null;

    self.onCultureChange = function () {
        $.ajax({
            dataType: 'json',
            success: function (result) {
                window.location.reload(true);
            },
            type: 'PUT',
            url: 'api/CultureApi/SetCulture?culture=' + self.cultureData.value()
        });
    };

    return self;
};