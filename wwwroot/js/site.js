function showHideSection10b(selection) {

    var Section10b = document.getElementById('Section10b');
    if (selection === 'yes') {
        Section10b.style.display = 'block';
    } else {
        Section10b.style.display = 'none';
    }
}

function showHideReasonSection(selection) {
    var reasonSection = document.getElementById('q5b');
    var otherReasonDetails = document.getElementById('OtherReasonDetails');

    if (selection === 'no') {
        reasonSection.style.display = 'block';
    } else {
        reasonSection.style.display = 'none';
        otherReasonDetails.style.display = 'none';
    }
}

function showHideImmigrantDetails(selection) {
    var immigrantDetails = document.getElementById('ImmigrantDetails');
    if (selection === 'yes') {
        immigrantDetails.style.display = 'block';
    } else {
        immigrantDetails.style.display = 'none';
    }
}

function showHideNonCitizenDetails(selection) {
    var nonCitizenDetails = document.getElementById('NonCitizenDetails');
    if (selection === 'no') {
        nonCitizenDetails.style.display = 'block';
    } else {
        nonCitizenDetails.style.display = 'none';
        
    }
}



