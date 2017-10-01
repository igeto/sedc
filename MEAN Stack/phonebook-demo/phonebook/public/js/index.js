let apiUrl = 'http://localhost:3000';

let reloadList = () => {
    $.get(apiUrl + '/getContactList', (data, res) => {
        if (data) {
            for(x in data) {
                $('#list ul').append('\
                    <li>\
                        <div>'+data[x].contactName+'</div>\
                        <div>'+data[x].contactEmail+'</div>\
                        <div>'+data[x].contactPhoneNumber+'</div>\
                        <div>'+data[x].contactMobileNumber+'</div>\
                    </li>\
                ');
            }
        }
    });
}

$(() => {
    (() => {
        $.get(apiUrl + '/getList', data => { 
            $('#list').html(data); 
            reloadList(); 
        });
    })();

    $('button[name="addContact"]').on('click', () => {
        $.get(apiUrl + '/getNewForm', data => $('#form').html(data));
    });
    
    $(document).on('click', 'button[name="saveForm"]', e => {
        e.preventDefault();
        var data = {};
        var form = $('form[name="newContact"]').find('input');

        for (var f = 0; f < form.length; f++) {
            data[form[f].name] = form[f].value;
        }
        $.post(apiUrl + '/postNewContact', data, res => {
            $('form[name="newContact"]')[0].reset();
        });
    });    
});