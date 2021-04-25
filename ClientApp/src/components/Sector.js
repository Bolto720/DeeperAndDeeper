import React, { StyleSheet } from "react";
import "./Sector.css";

function Sector(props) {

  return (
    <button
      className="square"
      onClick={() => props.sectorSelected(props.sector)}
      style={{ left: props.sector.pos.x * 50, top: props.sector.pos.y * 50 }}
    >
      {props.sector.pos.y}/{props.sector.pos.x}
    </button>
  );
}

export default Sector;
