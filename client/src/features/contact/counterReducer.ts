export const INCREAMENT_COUNTER = "INCREAMENT_COUNTER";
export const DECREAMENT_COUNTER = "DECREAMENT_COUNTER";

export interface CounterState {
  data: number;
  title: string;
}

const initialState: CounterState = {
  data: 42,
  title: "YARC (yet another redux counter)",
};

export function increment(amount = 1) {
  return {
    type: INCREAMENT_COUNTER,
    payload: amount,
  };
}

export function decrement(amount = 1) {
  return {
    type: DECREAMENT_COUNTER,
    payload: amount,
  };
}

export default function counterReducer(state = initialState, action: any) {
  switch (action.type) {
    case INCREAMENT_COUNTER:
      return {
        ...state,
        data: state.data + action.payload,
      };

    case DECREAMENT_COUNTER:
      return {
        ...state,
        data: state.data - action.payload,
      };

    default:
      return state;
  }
}
