<template>
  <h2 v-if="loading">Loading...</h2>
  <h2 v-if="error">{{ error.message }}</h2>
  <table class="tabla" v-if="result && result.mercaderia">
    <tr>
      <th>NOMBRE</th>
      <th>CATEGORIA</th>
      <th>Precio100gr</th>
      <th>PrecioKg</th>
      <th>BORRAR</th>
    </tr>
    <tr v-for="item in result.mercaderia" :key="item.idMercaderia">
      <td>{{ item.nombre }}</td>
      <td>{{ item.categoria.nombreCategoria }}</td>
      <td>{{ item.precioPor100gr }}</td>
      <td>{{ item.precioPorKg }}</td>
      <td>
        <button @click="deleteMercaderia({ id: item.idMercaderia })">
          BORRAR
        </button>
      </td>
    </tr>
  </table>
</template>

<script>
import { GET_ALL_MERCADERIA, DELETE_MERCADERIA } from "../graphql/Mercaderia.js";
import { useQuery, useMutation } from "@vue/apollo-composable";
export default {
  props: {
    data: {},
  },

  setup() {
    const { result, loading, error } = useQuery(GET_ALL_MERCADERIA);
    const { mutate: deleteMercaderia } = useMutation(DELETE_MERCADERIA, 
      {
        update(cache, { data: { deleteMercaderia } }) {
          const existingMercaderia = cache.readQuery({ query: GET_ALL_MERCADERIA });
          const newMercaderia = existingMercaderia.mercaderia.filter(m => m.idMercaderia !== deleteMercaderia.mercaderia.idMercaderia);
          cache.writeQuery({
            query: GET_ALL_MERCADERIA,
            data: { mercaderia: newMercaderia }
          });
        }
      }
    );

    return {
      result,
      loading,
      error,
      deleteMercaderia,
    };
  },
};
</script>

<style>
.tabla,
.tabla th,
.tabla td {
  border: 1px solid black;
}
</style>