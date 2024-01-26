import "./assets/style/mainmain.css";
import ImageDisplay from "./components/ImageDisplay.vue";

import { createApp } from 'vue';
import App from './Main.vue';

const app = createApp(App);

// https://stackoverflow.com/questions/66024797/vue-3-failed-to-resolve-component-with-global-components
app.component('ImageDisplay', ImageDisplay);

const mountedApp = app.mount('#app');
