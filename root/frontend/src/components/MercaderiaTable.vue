<template>
  <table class="tabla" v-if="data && data.mercaderia">
      <tr>
        <th>NOMBRE</th>
        <th>CATEGORIA</th>
        <th>Precio100gr</th>
        <th>PrecioKg</th>
        <th>BORRAR</th>
      </tr>
      <tr v-for="item in data.mercaderia" :key="item.idMercaderia">
        <td>{{ item.nombre }}</td>
        <td>{{ item.categoria.nombreCategoria }}</td>
        <td>{{ item.precioPor100gr }}</td>
        <td>{{ item.precioPorKg }}</td>
        <td><a @click="deleteMercaderia({ id: item.idMercaderia })">BORRAR</a></td>
      </tr>
    </table>
</template>

<script>
import { useMutation } from '@vue/apollo-composable';
import gql from 'graphql-tag';
export default {
  props: {
    data: {},
  },

  setup() {
    const { mutate: deleteMercaderia } = useMutation(
      gql`mutation deleteMercaderia($id: Int!) {
        deleteMercaderia(input: { id: $id }) {
          mercaderia {
            idMercaderia
          }
        }
      }`
    )

    return {
      deleteMercaderia
    }
  }
}
</script>

<style>
.tabla,
.tabla th,
.tabla td {
  border: 1px solid black;
}
</style>