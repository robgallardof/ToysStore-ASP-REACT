import { toyDTO } from "./toys.models";
import css from "./IndividualToy.module.css";

export default function IndividualToy(props: individualToyProps) {
  // Construcción del Link.
  const buildLink = () => `/toy/${props.toy.id}`;

  return (
    <div className={css.div}>
      <a href={buildLink()}>
        <img src={props.toy.image} alt="Imagen" />
      </a>
      <p>
        <a href={buildLink()}>{props.toy.name}</a>
      </p>
    </div>
  );
}

interface individualToyProps {
  toy: toyDTO;
}
