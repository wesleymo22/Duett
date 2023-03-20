import "./Feira.css"
import axios from "axios"
import { useEffect, useState } from "react"
import { Modal, ModalHeader, ModalBody, ModalFooter } from "reactstrap"




export default function Feira() {

    const baseUrl = "https://localhost:7155/api/Frutas"
    const [data, setData] = useState([])
    const [modal, setModal] = useState(false)

    const [frutaSelecionada, setFrutaSelecionada] = useState([])

    const abrirFecharModal = () => {
        setModal(!modal)
    }

    const pedidoGet = async () => {
        await axios.get(baseUrl)
            .then(response => {
                setData(response.data);
            }).catch(error => {
                console.log(error)
            })
    }

    const frutaGet = async (id) => {
        await axios.get(baseUrl + `/${id}`)
            .then(response => {
                setFrutaSelecionada(response.data);
            }).catch(error => {
                console.log(error)
            })
        abrirFecharModal()
    }

    useEffect(() => {
        pedidoGet();
    })

    const multiplicar = (a, b) => {
        const total = a * b
        alert(`${total}`);
        abrirFecharModal()
    }

    const dividir = (a, b) => {
        const total = a / b
        alert(`${total}`);
        abrirFecharModal()
    }



    return (
        <>
            <header>
                <h1>Feirao da Primavera</h1>
            </header>
            <main>
                <table>
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Fruta</th>
                            <th>A</th>
                            <th>B</th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
                        {data.map(frutas => (
                            <tr key={frutas.frutaId}>
                                <td>{frutas.frutaId}</td>
                                <td>{frutas.fruta}</td>
                                <td>{frutas.valorA}</td>
                                <td>{frutas.valorB}</td>
                                <td><button onClick={() => frutaGet(frutas.frutaId)}>Detalhes</button></td>
                            </tr>
                        ))}
                    </tbody>
                </table>

                <Modal isOpen={modal} className={"modal"}>
                    <ModalHeader className="modal__header">
                        <h2>{frutaSelecionada.fruta}</h2>
                        <button className="botao_fechar" onClick={() => abrirFecharModal()}>Sair</button>
                    </ModalHeader>
                    <ModalBody>
                        ID: {frutaSelecionada.frutaId}
                        <br />
                        Valor A: {frutaSelecionada.valorA}
                        <br />
                        Valor B: {frutaSelecionada.valorB}
                        <br />
                    </ModalBody>
                    <ModalFooter>
                        <button onClick={() => multiplicar(frutaSelecionada.valorA, frutaSelecionada.valorB)}>Multiplicar</button>
                        <button onClick={() => dividir(frutaSelecionada.valorA, frutaSelecionada.valorB)}>dividir</button>
                    </ModalFooter>
                </Modal>
            </main >
        </>
    )
}