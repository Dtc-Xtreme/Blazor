window.Alert = function (message) {
    alert(message);
}

window.returnStringAsync = () => {
    DotNet.invokeMethodAsync('BlazorServerApp', 'ReturnString')
        .then(data => {
            alert(data);
        });
};