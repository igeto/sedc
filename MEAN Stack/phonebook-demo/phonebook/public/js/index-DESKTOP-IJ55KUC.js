let apiUrl = 'http://localhost:3000';

let reloadList = () => {
    $.get(apiUrl + '/getContactList', (data, res) => {
        if (data) {
            for(x in data) {
                $('#list ul').append(`
                    <li>
                        <div><button id=${data[x]._id} class="btn btn-danger">delete</button></div>
                        <div><button id=${data[x]._id} class="btn btn-primary">edit</button></div>
                        <div>${data[x].contactName}</div>
                        <div>${data[x].contactEmail}</div>
                        <div>${data[x].contactPhoneNumber}</div>
                        <div>${data[x].contactMobileNumber}</div>
                    </li>
                `);
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
    $('#list').on('click', 'button', e => {
        let data = e.target.id;
        
        $.ajax({url: apiUrl + '/deleteContact/', type: 'DELETE', data, success: res => {
            e.target.parentElement.parentElement.remove()
        }});
    });
    
    $('#list').on('click', 'button', e => {
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