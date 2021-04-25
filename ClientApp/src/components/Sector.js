import React, {StyleSheet} from 'react'
import './Sector.css'

function Sector(props) {
    console.log(props);
    return (
        <div>
            <button className="square" style={{left: props.sector.pos.x * 100, top: props.sector.pos.y * 100}}>
                {props.sector.solarBodies.length}
                </button>
        </div>
    )
}

export default Sector
