function goElsewhere ( ) {
    document.location="https://google.com";
}
let limit = 30000 // in miliseconds

self.setTimeout('goElsewhere()', limit);

debugger;

function second(i){
    let countdown = document.getElementById("pizza mozarella");
    countdown.innerHTML = i;
}

for (let i = limit/1000; i>=0; i--){
    setTimeout(second,1000,i)
}