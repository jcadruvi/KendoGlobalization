function jobViewModel() {
    var self = {};

    self.endDateData = null;
    self.jobGridData = null;
    self.id = null;
    self.name = null;
    self.startDateData = null;

    var getSelectedJobId = function () {
        var dataItem;
        if (!self.jobGridData) {
            return null;
        }
        dataItem = self.jobGridData.dataItem(self.jobGridData.select());
        if (!dataItem) {
            return null;
        }
        return dataItem.Id;
    };
    

    self.onJobGridChange = function () {
        var postData = {};

        postData.Id = getSelectedJobId();

        $.ajax({
            data: postData,
            dataType: 'json',
            success: function (result) {
                self.id(result.Id);
                self.name(result.Name);
                if (self.endDateData) {
                    self.endDateData.value(new Date(result.EndDate));
                }
                if (self.startDateData) {
                    self.startDateData.value(new Date(result.StartDate));
                }
            },
            type: 'GET',
            url: 'api/JobApi/GetJob'
        });
    };

    self.setObservables = function() {

        self.id = ko.observable();
        self.name = ko.observable();
        
        ko.applyBindings(self);
    };

    return self;
}