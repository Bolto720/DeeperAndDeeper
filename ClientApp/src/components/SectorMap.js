import React, { useEffect, useState } from "react";
import Sector from "./Sector";

import './SectorMap.css';

export default function SectorMap(props) {
  const [sectors, setSectors] = useState([]);

  useEffect(() => {
    getSectors();
  }, []);

  const getSectors = async () => {
    const response = await fetch("sectormap");
    const data = await response.json();
    setSectors(data);
  };

  return (
    <div className="sectorContainer">
      {sectors.map((sec, i) => (
        <Sector sector={sec} sectorSelected={props.sectorSelected}></Sector>
      ))}
    </div>
  );
}
