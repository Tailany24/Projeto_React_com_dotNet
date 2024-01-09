import React, { useState, useEffect } from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';
import logoImage from './image/Voya-preview.png';

const Destino = () => {
  const [users, setUsers] = useState([]);

  // Aqui você faria uma requisição para o seu backend (API) para buscar os dados dos usuários
  useEffect(() => {
    // requisição para buscar dados do usuário no backend
    fetch('https://localhost:7017/api/Destinos')
      .then(response => response.json())
      .then(data => {
        const modifiedData = data.map(user => ({
          ...user,
          dataIda: user.dataIda.split('T')[0], // Obtendo somente a parte da data
          dataVolta: user.dataVolta.split('T')[0], // Obtendo somente a parte da data
        }));
        setUsers(modifiedData);
      })
      .catch(error => console.error('Erro ao buscar usuários:', error));
  }, []);

  return (
    <div>
      <div>
        <meta charSet="UTF-8" />
        <link rel="shortcut icon" href="Imagem/Agencia_Voya__favicon.png" type="image/x-icon" />
        <title>Novo Usuário</title>
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" />

        <nav className="navbar navbar-expand-md bg-menu">
          <div className="container-fluid">

          <img src={logoImage} alt="Logo" className="navbar-brand logo-image" />

            <button className="navbar-toggler" type="button" data-bs-toggle="collapse"
              data-bs-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false"
              aria-label="Toggle navigation">
              <span className="navbar-toggler-icon"></span>
            </button>
            <div className="collapse navbar-collapse justify-content-end" id="navbarNavAltMarkup">
              <div className="navbar-nav ps-1 d-flex mx-auto">
                <a className="nav-link" href="./">Lista Usuarios</a>
                <a className="nav-link botao-rosa" href="/Destino">Lista Destinos</a>
                <a className="nav-link" href="/Promocao">Lista Promoções</a>
              </div>
            </div>
          </div>
        </nav>
      </div>
      <div className="container">
        <h2>Lista de Destinos</h2>
        <table className="table">
          <thead>
            <tr>
              <th>Formas de Pagamento</th>
              <th>Destino da Viagem</th>
              <th>Data de Ida</th>
              <th>Data de Volta</th>
            </tr>
          </thead>
          <tbody>
            {users.map((user, index) => (
              <tr key={index}>
                <td>{user.pagamento}</td>
                <td>{user.destinoViagem}</td>
                <td>{user.dataIda}</td>
                <td>{user.dataVolta}</td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </div>
  );
};

export default Destino;

