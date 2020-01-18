function FetchRegion() {

    var RegionList = $("#RegionList");

    var CityId = $("#CityList").children("option:selected").val();

    RegionList.empty();

    $.ajax({
        url: '/Maintenances/FetchRegion',
        method: 'GET',
        dataType: 'json',
        accept: 'application/json',
        data: { CityId: CityId },
        success: function (data) {
            $.each(data, function (index, item) {
                var p = new Option(item.Text, item.Value);
                RegionList.append(p);
            });
        }
    });   //todo: ajax fail olursa       

}