<template>
  <main>
    <button @click="isAddMercaderiaFormOpen = true">Add Mercaderia</button>

    <add-mercaderia-form
      v-if="isAddMercaderiaFormOpen"
      @close="isAddMercaderiaFormOpen = false"
    >
    </add-mercaderia-form>

    <mercaderia-table></mercaderia-table>
  </main>
</template>

<script>
import { ref } from "vue";
import MercaderiaTable from "./components/MercaderiaTable";
import AddMercaderiaForm from "./components/AddMercaderiaForm";

export default {
  name: "App",
  components: {
    MercaderiaTable,
    AddMercaderiaForm,
  },

  setup() {
    const isAddMercaderiaFormOpen = ref(false);

    return {
      isAddMercaderiaFormOpen,
    };
  },
};
</script>

<style>
main {
  display: flex;
  justify-content: center;
  flex-direction: column;
}
</style>
