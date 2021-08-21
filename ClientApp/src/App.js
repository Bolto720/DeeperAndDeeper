import React, { Component } from "react";
import { Route } from "react-router";
import Label from "reactstrap/lib/Label";
import { Layout } from "./components/Layout";
import SectorInfo from "./components/SectorInfo";

import SectorMap from "./components/SectorMap";
import SolarBodyInfo from "./components/SolarBodyInfo";

import "./App.css";

export default class App extends Component {
  static displayName = App.name;

  constructor(props) {
    super(props);
    this.state = {
      currentSector: null,
      currentSolarBody: null,
    };
  }

  sectorSelected = (sector) => {
    this.setState({currentSector: sector, currentSolarBody: null});
  }

  solarBodySelected = (solarBody) => {
    this.setState({currentSolarBody: solarBody});
  }

  render() {
    return (
      <Layout>
        <div className={"mainPanel"}>
          <div className={"leftPanel"}>
          <SectorInfo sector={this.state.currentSector} solarBodySelected={this.solarBodySelected}></SectorInfo>
          <SolarBodyInfo solarBody={this.state.currentSolarBody}></SolarBodyInfo>
          </div>
          <div className={"rightPanel"}>
            <SectorMap sectorSelected={this.sectorSelected}></SectorMap>
            <label>test</label>
          </div>
        </div>
      </Layout>
    );
  }
}
