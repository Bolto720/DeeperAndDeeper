import React, { Component } from "react";
import { Route } from "react-router";
import Label from "reactstrap/lib/Label";
import { Layout } from "./components/Layout";
import SectorInfo from "./components/SectorInfo";

import SectorMap from "./components/SectorMap";

import "./custom.css";

export default class App extends Component {
  static displayName = App.name;

  constructor(props) {
    super(props);
    this.state = {
      currentSector: null
    };
  }

  sectorSelected = (sector) => {
    console.log(sector.pos.x);
    this.setState({currentSector: sector});
  }

  render() {
    return (
      <Layout>
        <div className={"mainPanel"}>
          <div className={"leftPanel"}>
          <SectorInfo sector={this.state.currentSector}></SectorInfo>
          </div>
          <div className={"rightPanel"}>
            {/* <div className={"topRightPanel"}> */}
            <SectorMap sectorSelected={this.sectorSelected}></SectorMap>
            {/* </div> */}
            {/* <div className={"bottomRightPanel"}>               */}
           
            {/* </div> */}
          </div>
        </div>
        {/* <SectorMap></SectorMap> */}
      </Layout>
    );
  }
}
