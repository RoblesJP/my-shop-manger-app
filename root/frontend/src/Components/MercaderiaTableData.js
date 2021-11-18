import React, { useState, useEffect } from 'react'

function MercaderiaTableData() {
    var initialState = [];
    const [state, setState] = useState(initialState)
    
    useEffect(() => {
        let myQuery = `
        #graphql
        query {
            mercaderia {
                idMercaderia
                nombre
                categoria {
                    nombreCategoria
                }
            }
        }
        `
        fetch
            (
                'https://localhost:44378/graphql', {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json',
                        'Accept': 'application/json',
                    },
                    body: JSON.stringify({
                        query: myQuery
                    })
                }
            )
            .then(res => res.json())
            .then(data => setState(data.data.mercaderia));
    }, [initialState.length]);
    

    return (
        <tbody>
        {state.map((item) => {
            return(
                <tr key={ item.idMercaderia }>
                    <td> { item.nombre } </td>
                    <td> { item.categoria.nombreCategoria } </td>
                </tr>
            )
        })}
        </tbody>
    );
}

export default MercaderiaTableData;