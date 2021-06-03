<template>
  <div>
    <q-card class="row q-my-md">
      <q-card-section class="row col-12">
        <div class="text-h6 col-12 q-my-none">Indberetning*</div>
        <q-option-group
          class="col-12"
          v-model="group"
          :options="options"
          color="primary"
        />
        <p class="q-mt-sm q-mb-none" v-if="group == 'intime'">
          Pris <span class="text-weight-bold">DKK 370,00</span> inkl. moms
        </p>
        <p class="q-mt-sm q-mb-none" v-if="group == 'delayed'">
          Pris <span class="text-weight-bold">DKK 490,00</span> inkl. moms
        </p>
        <p class="q-mt-sm q-mb-none" v-if="group == 'nextyear'">
          Pris <span class="text-weight-bold">DKK 1.370,00</span> inkl. moms
        </p>
      </q-card-section>
    </q-card>
  </div>
</template>

<script>
export default {
  // name: 'ComponentName',
  data() {
    return {
      group: "",
      options: [
        {
          label: "Rettidig",
          value: "intime"
        },
        {
          label: "Forsinket",
          value: "delayed"
        },
        {
          label: "Efter årets udgang",
          value: "nextyear"
        }
      ]
    };
  }
};
</script>
