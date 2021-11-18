import React from 'react'
import MercaderiaTableData from './MercaderiaTableData'

function MercaderiaTable() {
    return (
        <div className="MercaderiaTalbe">
            <table className="table">
                <thead>
                    <tr>
                        <th>NOMBRE</th>
                        <th>CATEGORIA</th>
                    </tr>
                </thead>
                <MercaderiaTableData/>
            </table>
        </div>
    )

}

export default MercaderiaTable;