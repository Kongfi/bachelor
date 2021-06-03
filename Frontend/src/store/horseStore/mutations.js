export function loadHorses(state, horses) {
  state.horses = horses;
}

export function addHorse(state, horse) {
  state.horses.push(horse);
}

export function deleteHorse(state, id) {
  const index = state.horses.map(x => x.id).indexOf(id);
  if (index > -1) {
    state.horses.splice(index, 1);
  }
}
