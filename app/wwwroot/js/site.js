// setup Bootstrap 4 Forms Validation
(function() {
    "use strict";
    window.addEventListener("load",
        function() {
            // Fetch all the forms we want to apply custom Bootstrap validation styles to
            var forms = document.getElementsByClassName("needs-validation");
            // Loop over them and prevent submission
            var validation = Array.prototype.filter.call(forms,
                function(form) {
                    form.addEventListener("submit",
                        function(event) {
                            if (form.checkValidity() === false) {
                                event.preventDefault();
                                event.stopPropagation();
                                // cancel the spinner
                                window.setTimeout(function () {
                                    $('div#progress-overlay').hide();
                                }, 100);
                            }
                            form.classList.add("was-validated");
                        },
                        false);
                });
        },
        false);
})();

$(document).ready(function () {

    // Init Tooltips
    $('[data-toggle="tooltip"]').tooltip();

    //caches a jQuery object containing the header element
    var header = $("#scj-header-nav");
    $(window).scroll(function() {
        var scroll = $(window).scrollTop();
        if (scroll >= 85) {
            header.addClass("affixed");
        } else {
            header.removeClass("affixed");
        }
    });

    // phone number inputs - form field data tidy up
    $("input.phone-input").change(function () {
        var phone = this.value.replace(/[^0-9]/g, "");

        if (phone.indexOf("1") === 0) {
            phone = phone.substr(1);
        }

        if (phone.length === 10) {
            this.value = phone.replace(/(\d{3})(\d{3})(\d{4})/, "$1-$2-$3");
        }
    });

    // Set up the progress spinner overlay
    $('body').on('click', 'input.progress-spinner, a.progress-spinner, button.progress-spinner', function () {
        $('div#progress-overlay').show();
        $('div#progress-overlay-spinner').spin();
    });

    // kills the spinner when the back button is pressed 
    window.onunload = function () { };

    // CoA additional questions for Civil cases
    //$("#btnNextCoa").click(function (e) {
    //    e.preventDefault();
    //    $("#pnlCoaCivil").toggle();
    //    $("#btnNextCoa").toggle();
    //    $("#btnSubmitCoa").toggle();

    //    // scroll down to additional questions panel
    //    if ($("#btnSubmitCoa").css("display") !== "none") {
    //        var panel = $("div[id='pnlCoaCivil']");
    //        $("html,body").animate({ scrollTop: panel.offset().top }, "fast");
    //    }
    //});

    // Give active style class to checked radio button input
    var $radiobtns = $('input[type="radio"]');
    $radiobtns.click(function () {
        $radiobtns.each(function () {
            $(this).parent().toggleClass('active', this.checked);
        });
    });


    //Display last row of questions for Civil case if previous questions are answered Yes
    var toggleCivil = function () {
        var $CivilCertificateOfReadiness = $('input[name="CivilCertificateOfReadiness"]:checked').val();
        var $CivilDateIsAgreed = $('input[name="CivilDateIsAgreed"]:checked').val();
        if ($CivilCertificateOfReadiness === 'true' && $CivilDateIsAgreed === 'true') {
            $('#CivilAdditionalQs').toggle();
        }
    };

    $('input[name="CivilCertificateOfReadiness"]').click(toggleCivil);
    $('input[name="CivilDateIsAgreed"]').click(toggleCivil);


    //Display last row of questions for Criminal case if previous questions are answered Yes
    var toggleCriminal = function () {
        var $CriminalLowerCourtOrder = $('input[name="CriminalLowerCourtOrder"]:checked').val();
        var $CriminalDateIsAgreed = $('input[name="CriminalDateIsAgreed"]:checked').val();
        if ($CriminalLowerCourtOrder === 'true' && $CriminalDateIsAgreed === 'true') {
            $('#CriminalAdditionalQs').toggle();
        }
    };

    $('input[name="CriminalLowerCourtOrder"]').click(toggleCriminal);
    $('input[name="CriminalDateIsAgreed"]').click(toggleCriminal);
});

// Called by Vue when a timeslot is selected
function validateCaseDate(containerId, bookingDate) {
    //set hidden fields based on the swiper selected dates
    $("#hidContainerId").val(containerId);
    $("#hidDate").val(bookingDate);

    //submit the form to go to the next page
    $("#btnSearch").trigger("click");
}

