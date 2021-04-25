import React from "react";

import "./SolarBodyInfo.css";

function SolarBodyInfo(props) {
  if (props.solarBody === null) {
    return (
      <div className="mainSolarBodyInfo">
        <label>
          <h4>Solar Body Information</h4>
        </label>
        <label>Select a solar body</label>
      </div>
    );
  } else {
    return (
      <div className="mainSolarBodyInfo">
          <h4>Solar Body Information</h4>
          <label><strong>Type: {props.solarBody.typeName}</strong></label>
          <label><strong>Resources: {props.solarBody.resources.length}</strong></label>
          {props.solarBody.resources.map((resource, i) => (
            <div className="solarBody">
              <label className="solarBodyLabel">{resource.resourceType}:</label>
              <label className="solarBodyLabel"> {resource.amount} tonnes</label>
              <button className="solarBodyButton">Mine</button>
              </div>
          ))}
      </div>
    );
  }
}

export default SolarBodyInfo;
