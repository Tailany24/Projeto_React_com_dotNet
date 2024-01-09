import React from 'react';
import Usuario from "./Usuario";
import Destino from "./Destino";
import Promocao from "./Promocao" ;
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";

const AppRoutes = () => {
    return (
        <Router>
            <Routes>
                <Route path="/" element={<Usuario />} />
                <Route path="/destino" element={<Destino />} />
                <Route path="/promocao" element={<Promocao />} />
            </Routes>
        </Router>
    );
}

export default AppRoutes;
