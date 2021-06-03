<template>
  <div>
    <h1 class="text-h6 col-12 text-center">Tilknyttede heste</h1>
    <q-markup-table bordered square class="row col-12 col-md-4 q-mt-none">
      <thead>
        <tr>
          <th class="text-left">Navn</th>
          <th class="text-left">Fra</th>
          <th class="text-left">Stald</th>
          <th class="text-left">Køn</th>
          <th class="text-left">Fødselsår</th>
        </tr>
      </thead>
      <tbody>
        <tr
          v-for="value in horses"
          :key="value.id"
          @click="horseIdToDelete(value.id)"
          class="cursor-pointer"
        >
          <td class="text-left">{{ value.name }}</td>
          <td class="text-left">{{ value.from }}</td>
          <td class="text-left">{{ value.stable }}</td>
          <td class="text-left">{{ value.gender }}</td>
          <td class="text-left">{{ value.birthYear }}</td>
        </tr>
      </tbody>
    </q-markup-table>

    <div class="flex justify-center q-mt-sm">
      <q-btn color="primary" label="Tilføj hest" @click="addHorse = true" />
    </div>

    <q-dialog v-model="addHorse">
      <q-card>
        <addHorse @emitHorse="addNewHorse"></addHorse>
      </q-card>
    </q-dialog>

    <q-dialog v-model="editHorse">
      <q-card class="flex justify-evenly q-gutter-md">
        <q-icon name="mdi-pencil" size="lg" />
        <q-icon name="mdi-delete" size="lg" @click="deleteHorse" />
      </q-card>
    </q-dialog>
  </div>
</template>

<script>
import AddHorse from "components/profile/AddHorseDialog";
import { mapActions } from "vuex";

export default {
  name: "HorseList",

  components: {
    AddHorse
  },

  data() {
    return {
      addHorse: false,
      editHorse: false,
      editHorseID: null
    };
  },

  mounted: function() {
    this.$store.dispatch("horseStore/loadHorses");
  },

  computed: {
    horses: {
      get() {
        return this.$store.state.horseStore.horses;
      }
    }
  },

  methods: {
    addNewHorse(payload) {
      this.$store.dispatch("horseStore/addHorse", payload.horse);
    },

    deleteHorse() {
      this.$store.dispatch("horseStore/deleteHorse", this.editHorseID);
    },

    horseIdToDelete(id) {
      this.editHorse = true;
      this.editHorseID = id;
    }
  }
};
</script>

<style lang="scss" scoped>
.q-card {
  width: 800px;
  max-width: 80vw;
}
</style>
