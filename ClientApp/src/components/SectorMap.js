import React, { useEffect, useState } from 'react'
import Sector from './Sector'

export default function SectorMap() {
    const [sectors, setSectors] = useState([]);

    useEffect(() => 
    {
            getSectors();
    }, []);

const getSectors = async () => {
    const response = await fetch('sectormap');
    const data = await response.json();
    setSectors(data);
}

    return (
        <div>            
            {sectors.map((sec, i) => (
                <Sector sector={sec}></Sector>
            ))}
        </div>
    )
}
