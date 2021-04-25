import React, { useState } from "react";
import "./Sector.css";

import starmap_0 from '../starmaps/starmaps_0.png'
import starmap_1 from '../starmaps/starmaps_1.png'
import starmap_2 from '../starmaps/starmaps_2.png'
import starmap_3 from '../starmaps/starmaps_3.png'
import starmap_4 from '../starmaps/starmaps_4.png'
import starmap_5 from '../starmaps/starmaps_5.png'
import starmap_6 from '../starmaps/starmaps_6.png'
import starmap_7 from '../starmaps/starmaps_7.png'
import starmap_8 from '../starmaps/starmaps_8.png'


function Sector(props) {
  const [sector, setSector] = useState(null);

  const images = [
    starmap_0,
    starmap_1,
    starmap_2,
    starmap_3,
    starmap_4,
    starmap_5,
    starmap_6,
    starmap_7,
    starmap_8,
  ]

  const handleClick = () => {
    setSector(props.sector);    
    props.sectorSelected(props.sector);    
  }

  return (
    <button
      className="square"
      onClick={handleClick}      
    >
        <img className="image" src={images[Math.floor(Math.random() * 9)]}/>        
    </button>
  );
}

export default Sector;
