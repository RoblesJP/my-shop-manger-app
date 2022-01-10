<template>
  <main>
    <h2 v-if="loading">Loading...</h2>
    <h2 v-if="error">{{ error.message }}</h2>
    <mercaderia-table v-if="result" :data="result"></mercaderia-table>
  </main>
</template>

<script>
import gql from "graphql-tag";
import { useQuery } from "@vue/apollo-composable";
import MercaderiaTable from "./components/MercaderiaTable.vue"

export default {
  name: "App",
  components: { MercaderiaTable },
  setup() {
    const { result, loading, error } = useQuery(
      gql`
        query GetAllMercaderia {
          mercaderia {
            idMercaderia
            nombre
            categoria {
              nombreCategoria
            }
            precioPor100gr
            precioPorKg
          }
        }
      `
    );

    return {
      result,
      loading,
      error
    };
  },
};
</script>

<style>
main {
  display: flex;
  justify-content: center;
}
</style>
