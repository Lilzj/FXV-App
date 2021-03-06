
var event_id = $('#event-id-tag').attr('event_id');

function addMember() {
    var action = "SearchUsers";
    var index = $("#members").find("tbody").find("tr").length;
    var HTML = ('<tr class="row pb-2"><td class="col-7"><input autocomplete="off" id="Members_{}" class="w-100 form-control" name="Members[{}]" type="text" value=""onkeyup="input_onkeyup(this,\'' + action + '\')" onfocus="input_onfocus(this)" onfocusout="input_onfocusout(this)" type="text" value=""><ul class="border border-dark col-12 list-group p-0" hidden=""></ul><div hidden=""><input id="Members_Full_{}__Id" name="Members_Full[{}].Id" hidden=""></div ></td><td class="col-4"><a href="javascript:void(0)" onclick="removeMember(this)">Remove</a></td></tr>').replace(/{}/g, index);

    $("#members").find("tbody").append(HTML);
}
function removeMember(e) {
    $(e).parents("tr").remove();
    var tb = $("#members").first();
    var count = tb.find("tbody").find("tr").length;
    for (var i = 0; i < count; i++) {
        var newTR = tb.find("tr").eq(i).html().replace(/\[\d+\]/g, '[' + i + ']').replace(/_\d+/g, '_' + i);
        tb.find("tr").eq(i).html(newTR);
    }
}
function submit() {

    $('#loading-panel').removeAttr('hidden');

    var form = document.getElementById('CreateEventAttendee');
    var formData = new FormData(form);
    formData.append('event_id', event_id);
    $.ajax({
        type: 'POST',
        url: '../EventInfo/AssignEventAttendee',
        data: formData,
        cache: false,
        processData: false,
        contentType: false,
        dataType: 'html',
        success: function (data) {
            var str = data.toString();
            if (str.indexOf("<!--This is the login layout-->") == 0) {
                alert("The system detects that you have not operated for a long time, please login again");
                document.clear();
                location.reload();
            }
            else {
                var EXECUTEDSUCCESS = str.indexOf("<!--EventInfo-->") == 0;

                switch (EXECUTEDSUCCESS) {
                    case true:
                        $('#body-content').html(data);
                        SuccessTurnToParentPage("Success", true);
                        return;
                    case false:
                        $('#body-content').html(data);
                        SuccessTurnToParentPage("Failed", false);
                        return;
                }
            }
        },
        error: function (xhr) {
            $("#body-content").html(xhr.responseText);
        }
    });

    
}
