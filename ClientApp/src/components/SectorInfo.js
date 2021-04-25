import React from "react";
import "./SectorInfo.css";

function SectorInfo(props) {
  if (props.sector === null) {
    return (
      <div className="mainSectorInfo">
        <label>
          <h3>Sector Information</h3>
        </label>
        <label>Select a sector</label>
      </div>
    );
  } else {
    return (
      <div className="mainSectorInfo">
        <label>
          <h3>Sector Information</h3>
        </label>
        <label>
          <strong>Coordinates: {props.sector.pos.y}:{props.sector.pos.x}</strong>
        </label>
        <label><strong>Solar bodies: {props.sector.solarBodies.length}</strong></label>
        <div className="solarBodies">
        {props.sector.solarBodies.map((sb, i) => (
            <button className="sectorInfoButton" 
            key={i}
            onClick={() => props.solarBodySelected(sb)} >{sb.typeName}</button>
        ))}
        </div>
      </div>
    );
  }
}

export default SectorInfo;
