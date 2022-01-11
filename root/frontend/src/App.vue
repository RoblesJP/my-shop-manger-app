<template>
  <main>
    <mercaderia-table></mercaderia-table>
  </main>
</template>

<script>
import MercaderiaTable from "./components/MercaderiaTable.vue"

export default {
  name: "App",
  components: { MercaderiaTable },
  
};
</script>

<style>
main {
  display: flex;
  justify-content: center;
}
</style>
