import { useEffect, useState } from "react";
import { List, ListItem } from "@mui/material";
import { Rol } from "../models/Rol";
import Sidebar from "../../components/Sidebar";

function App() {
  const [roles, setRoles] = useState<Rol[]>([]);

  useEffect(() => {
    fetch("http://localhost:5000/api/roles")
      .then((response) => response.json())
      .then((data) => setRoles(data));
  }, []);

  return (
    <div>
      <h1>Facturacion React</h1>

      <Sidebar />
      <List>
        {roles.map((item, index) => (
          <ListItem key={index}>{item.nombre}</ListItem>
        ))}
      </List>
    </div>
  );
}

export default App;
