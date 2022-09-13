import { NavLink } from "react-router-dom";

export default function Menu(){
    
    // const activeClass = "active";

    return(
        <nav className="navbar navbar-expand-lg navbar-light bg-light">
            <div className="container-fluid">
                <NavLink className={isActive => "navbar-brand" + (!isActive ? " unselected" : "") } to="/">React ToysStore</NavLink>
                <div className="collapse navbar-collapse">
                    <u className="navbar-nav me-auto mb-2 mb-lg-0">
                        <li className="nav-item">
                            <NavLink   className={isActive => "nav-link" + (!isActive ? " unselected" : "") } to="/category">Categoria</NavLink>
                        </li>
                    </u>
                </div>
            </div>
        </nav>
    )
}