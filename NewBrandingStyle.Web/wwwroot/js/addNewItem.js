(function () {
    const alertElement = document.getElementById("success-alert");
    const formElement = document.forms[0];

    const addNewItem = async () => {
        const Name = document.querySelector('#Name').value;
        const Description = document.querySelector('#Description').value;
        const IsVisible = document.querySelector('#IsVisible').checked;

        const requestData = {
            Name,
            Description,
            IsVisible
        }

        const response = await fetch('/api/companyapi', {
            method: 'POST',
            headers: {
                'Content-type': 'application/json'
            },
            body: JSON.stringify(requestData),
        });

        const responseJson = await response.json();

        if (responseJson.success) {
            alertElement.style.display = 'block'
        }

        return responseJson;
    };
    window.addEventListener("load", () => {
        formElement.addEventListener("submit", event => {
            event.preventDefault();

            addNewItem().then((res) => console.log(res))
        });
    });

})();