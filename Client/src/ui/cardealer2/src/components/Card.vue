<template>
  <div v-for="(item, index) in items" :key="index" class="element-card">
    <h1>{{ item.name }}</h1>
    <img class="element-img" :src="item.image" alt="">
    <h5>{{ item.price }}$</h5>
    <button @click="buy(item)" class="element-btn">Choisir</button>
  </div>

</template>

<script>
/* eslint-disable no-undef */
export default {
  name: "CardComponent",
  data() {
    return {
      items: [
        {name: 'McLaren', model: 't20', price: 10000,  image: require('@/assets/1.png')},
        {name: 'McLaren', model: 't20', price: 10000, image: require('@/assets/1.png')}
      ]
    }
  },
  methods : {
    buy(item) {
      alt.emit('client:buy', item.price, item.model);
    }
  }
}
</script>

<style scoped>
@font-face {
  font-family: Akira;
  src: url('../assets/Akira.otf');
}
.element-card {
  position: relative;
  left: 10%;
  padding: 10px 30px;
  display: inline-block;
  margin-left: 30px;
  margin-top: 40px;
  opacity: .75;
  font-family: Akira,serif;
  font-size: 10px;
  color: white;
  width: 15%;
  border-radius: 10px;
  background: rgb(88,87,91);
  background: linear-gradient(157deg, rgba(88,87,91,1) 15%, rgba(145,114,153,1) 42%);
}
.element-img {
  width: 100%;
}

.element-btn {
  position: relative;
  transform: translate(-50%, 0%);
  left: 50%;
  background: transparent;
  border: 1px solid #e4c2f5;
  border-radius: 5px;
  color: white;
  height: 2.4em;
  width: 10em;
}

.element-btn:hover {
  background: #e4c2f5;
}

</style>