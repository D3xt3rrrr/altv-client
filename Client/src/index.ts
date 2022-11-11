import * as alt from 'alt-client';
import * as native from 'natives';
import './cardealer';

let webview
alt.on('connectionComplete', () => {
    alt.log("<--- Client has loaded --->")
    webview = new alt.WebView('http://resource/client/ui/login/page/index.html');
    webview.focus();
    alt.showCursor(true);
    alt.toggleGameControls(false);
    native.doScreenFadeIn(0);

    webview.on('client:login', (username, password) => {
        alt.emitServer('core:login', username, password);
    })

    webview.on('client:register', (username, password) => {
        console.log(username)
        alt.emitServer('core:register', username, password);
    })

})


alt.onServer('core:successLogin', () => {
    alt.showCursor(false);
    alt.toggleGameControls(true);
    native.doScreenFadeIn(1000);
    webview.destroy();
})

alt.onServer('core:init', (bank, cash) => {
    let playerUI = new alt.WebView('http://resource/client/ui/playerUI/index.html');
    playerUI.emit('ui:show', bank, cash);
})
