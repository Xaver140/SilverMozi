import { useLocation, useNavigate } from "react-router-dom";

export default function Fizetes(){
    const location = useLocation();
    const navigate = useNavigate();

    const { konyveles_ids, amount } = location.state || {};

    const [method, setMethod] = useState("credit_card");
}