<template>
  <main>
    <h2 v-if="loading">Loading...</h2>
    <h2 v-if="error">{{ error.message }}</h2>
    <table class="tabla" v-if="result && result.mercaderia">
      <tr>
        <th>NOMBRE</th>
        <th>CATEGORIA</th>
        <th>Precio100gr</th>
        <th>PrecioKg</th>
      </tr>
      <tr v-for="item in result.mercaderia" :key="item.idMercaderia">
        <td>{{ item.nombre }}</td>
        <td>{{ item.categoria.nombreCategoria }}</td>
        <td>{{ item.precioPor100gr }}</td>
        <td>{{ item.precioPorKg }}</td>
      </tr>
    </table>
  </main>
</template>

<script>
import gql from "graphql-tag";
import { useQuery } from "@vue/apollo-composable";

export default {
  name: "App",

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

.tabla,
.tabla th,
.tabla td {
  border: 1px solid black;
}
</style>
