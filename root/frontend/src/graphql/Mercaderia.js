import { gql } from "graphql-tag";
export const GET_ALL_MERCADERIA = gql`
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

export const DELETE_MERCADERIA = gql`
mutation deleteMercaderia($id: Int!) {
  deleteMercaderia(input: { id: $id }) {
    mercaderia {
      idMercaderia
    }
  }
}
`