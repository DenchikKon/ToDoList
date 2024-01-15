var forms = document.querySelectorAll('.form-check-input');

forms.forEach(function (form) {
    var checkbox = form.querySelector('.btn-check-input');

    checkbox.addEventListener('change', function (event) {
        var taskId = checkbox.id.split('_')[1];
        var formId = 'Task-form_' + taskId;

        // Автоматическая отправка формы при изменении состояния чекбокса
        document.getElementById(formId).submit();
    });
});

