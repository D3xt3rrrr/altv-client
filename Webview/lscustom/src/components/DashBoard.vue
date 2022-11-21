<template>
  <CardMod></CardMod>
</template>

<script>
import CardMod from "@/components/CardMod";
export default {
  name: 'DashBoard',
  components: {
    CardMod
  },
  props: {
    msg: String
  }
}
</script>

<style scoped>

</style>
