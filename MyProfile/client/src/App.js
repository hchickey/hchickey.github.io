import './App.css';
import React from "react";
import { BrowserRouter as Router } from "react-router-dom";
import { ApplicationViews } from "./components/ApplicationViews";
import { Header } from "./components/Header";


function App() {

  return (
    <Router>
      <Header />
      <ApplicationViews />
    </Router>
  );
}

export default App;
