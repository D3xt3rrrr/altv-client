import * as alt from 'alt-client';
import {getHashKey, placeObjectOnGroundProperly} from "natives";
import native from "natives";

let webview
alt.on('keydown', (key) => {
    if (key === 116) {
        webview = new alt.WebView('http://resource/client/ui/cardealer2/dist/index.html');
        webview.focus();
        alt.showCursor(true);
        alt.toggleGameControls(false);
        native.doScreenFadeIn(0);


        webview.on('client:buy', (price, model) => {
            alt.emitServer('core:buyCar', price, model);
            alt.showCursor(false);
            alt.toggleGameControls(true);
            native.doScreenFadeIn(1000);
            webview.destroy();
        })

        webview.on('cardealer:close', () => {
            alt.showCursor(false);
            alt.toggleGameControls(true);
            native.doScreenFadeIn(1000);
            webview.destroy();
        })
    }
})