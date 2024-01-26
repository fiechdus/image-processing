<script type="module">

export default {
    data() {
        return{
            uploadedImage: null
        };
    },
    methods: {
        handleUploadedImage(event) {
            let uploadedFile = event.target.files[0];
            if (uploadedFile && uploadedFile.type.startsWith('image/')) {
                this.uploadedImage = URL.createObjectURL(uploadedFile);
            }
        }
    }
}
</script>


<template>
    <body>
        <p>hello world</p>
        <input @change="handleUploadedImage" type="file">

        <image-display :uploaded-image="uploadedImage"></image-display>
    </body>
</template>