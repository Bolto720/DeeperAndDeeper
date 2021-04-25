import React from "react";
import "./SectorInfo.css";

function SectorInfo(props) {
  if (props.sector === null) {
    return (
      <div className="main">
        <label>
          <h3>Sector Information</h3>
        </label>
        <label>Select a sector</label>
      </div>
    );
  } else {
    return (
      <div className="main">
        <label>
          <h3>Sector Information</h3>
        </label>
        <label>
          Coordinates: {props.sector.pos.y}/{props.sector.pos.x}
        </label>
        <label>Solar bodies: {props.sector.solarBodies.length}</label>
      </div>
    );
  }
}

export default SectorInfo;
