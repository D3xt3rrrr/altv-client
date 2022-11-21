<template>
  <div v-for="item in items" :key="item.message" class="card">
    <div class="bg"></div>
    <div class="card-body">
      <div class="card-title">
        {{ item.message }}
      </div>
      <div class="card-img">

      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      items: [{message: 'Moteur'}, {message: 'Transmission'}, {message: 'Turbo'}, {message: 'Fenêtre'}]
    }
  },
  methods: {}
}
</script>

<style scoped>
.card {
  margin-right: 30px;
  color: #333;
  box-sizing: border-box;
  width: 271px;
  height: 148px;
  display: inline-block;
}

.bg {
  position: relative;
  top: 0;
  left: 0;
  width: 271px;
  height: 148px;
  background: rgba(74, 74, 74, 0.39);
  border-radius: 16px;
  box-shadow: 0 4px 30px rgba(0, 0, 0, 0.1);
  backdrop-filter: blur(10.4px);
  -webkit-backdrop-filter: blur(10.4px);
}

.card-body {
  position: relative;
  top: -100%;
}

.card-title {
  margin-top: 20px;
  color: white;
  letter-spacing: 2px;
}

</style>