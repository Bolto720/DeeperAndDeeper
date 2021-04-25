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
              <button className="solarBodyButton">{resource.resourceType}: {resource.amount}</button>
          ))}
      </div>
    );
  }
}

export default SolarBodyInfo;
