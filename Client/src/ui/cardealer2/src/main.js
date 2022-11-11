/* eslint-disable no-undef */
import App from './App.vue'
import {createApp} from "vue";

if ('alt' in window) {
    alt.on('webview:LoadApp', (appName, params) => {
        Controller.loadApp(appName, params)
    })

    alt.on('webview:DestroyApp', (appName) => {
        Controller.destroyApp(appName)
    })

    alt.on('webview:ChangePage', (appName, pageName, params) => {
        Controller.changePage(appName, pageName, params)
    })

    alt.on('webview:CallEvent', (eventName, ...args) => {
        EventManager.emit(eventName, ...args)
    })
}
createApp(App).mount('#app')

