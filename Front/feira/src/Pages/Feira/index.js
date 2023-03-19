import axios from "axios"
import { useEffect, useState } from "react"

export default function Feira() {

    const baseUrl = "https://localhost:7155/api/Frutas"
    const [data, setData] = useState([])

    const pedidoGet = async () => {
        await axios.get(baseUrl)
            .then(response => {
                setData(response.data);
            }).catch(error => {
                console.log(error)
            })
    }

    useEffect(() => {
        pedidoGet();
    })

    return (
        <>
            <h1>Feirão da Primavera</h1>
            <table>
                <thead>
                    <tr>
                        <th>Fruta</th>
                        <th>A</th>
                        <th>B</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    {data.map(frutas => (
                        <tr key={frutas.id}>
                            <td>{frutas.fruta}</td>
                            <td>{frutas.valorA}</td>
                            <td>{frutas.valorB}</td>
                            <td><button>Detalhes</button></td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </>
    )
}