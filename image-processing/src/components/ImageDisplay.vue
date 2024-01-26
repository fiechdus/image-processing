<script type="module">

export default {
    props: ['uploadedImage'],
    data() {
        return {
        };
    },
    methods: {
        onImageUploaded() {
            console.log('is this working?');
        }
    }
}
</script>


<template>
    <div class="image-display-container">
        <p>test image display</p>
        <img class="image-display" @load="onImageUploaded" v-if="uploadedImage" :src="uploadedImage">
    </div>
</template>

<style scoped>
@import '../assets/style/image-display.css';
</style>