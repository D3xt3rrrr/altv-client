<template>
  <div class="bg">
    <button @click="close">X</button>
    <card></card>
  </div>
</template>

<script>
/* eslint-disable no-undef */
import Card from "@/components/Card";

export default {
  name: 'App',
  components: {
    Card
  },
  methods : {
    close() {
      alt.emit('cardealer:close');
    }
  }
}
</script>

<style>
.bg {
  position: absolute;
  transform: translate(-50%, -50%);
  left: 50%;
  top: 50%;
  width: 50%;
  height: 50%;
  background: rgb(88,87,91);
  background: linear-gradient(157deg, rgba(88,87,91,1) 0%, rgba(61,61,61,1) 42%);
  border-radius: 15px;
  display: inline-block;
}

</style>
