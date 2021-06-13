<template>
  <div>
    <div class="row">
      <div class="row col-12">
        <h1 class="text-h6 col-12 q-mt-none q-mb-sm">
          Oplysninger om hingsteejer/holder
        </h1>

        <div class="text-body1 col-12">
          <span class="text-bold">Navn:</span> {{ user.firstName }}
          {{ user.lastName }}
        </div>
        <div class="text-body1 col-12">
          <span class="text-bold">Land:</span> {{ user.country }}
        </div>
        <div class="text-body1 col-12">
          <span class="text-bold">Postnummer:</span> {{ user.zipCode }}
          {{ user.city }}
        </div>
        <div class="text-body1 col-12">
          <span class="text-bold"> Adresse:</span> {{ user.address }}
        </div>
        <div class="text-body1 col-12">
          <span class="text-bold"> Email:</span> {{ user.email }}
        </div>
        <div class="text-body1 col-12">
          <span class="text-bold"> Tlf nummer:</span> {{ user.phone }}
        </div>
        <div class="text-body1 col-12">
          <span class="text-bold"> Køn:</span> {{ user.gender }}
        </div>
        <div
          v-if="$q.platform.is.mobile"
          class="col-12 flex justify-center q-mt-sm q-mb-md"
        >
          <q-btn
            outline
            color="cyan"
            label="Ret brugerinfo"
            @click="alert = !alert"
          />
        </div>
        <div
          v-if="!$q.platform.is.mobile"
          class="col-12 flex justify-end q-mt-md"
        >
          <q-btn
            flat
            color="cyan"
            label="Ret brugerinfo"
            @click="alert = !alert"
          />
        </div>
      </div>
      <q-card-section class="q-py-none q-pl-none">
        <div class="text-body1 text-weight-medium" label="">
          Ejerskab af hingst
        </div>
        <q-option-group
          v-model="group"
          :options="options"
          color="primary"
        ></q-option-group>
      </q-card-section>
    </div>

    <q-dialog v-model="alert">
      <q-card
        style="
  width: 800px;
  max-width: 80vw;
"
      >
        <h1 class="text-h6 text-center">Ret brugerinfo</h1>
        <q-input
          class="col-12 q-mx-lg"
          outlined
          v-model="changeUser.firstName"
          label="Fornavn"
          :rules="[val => !!val || '* Påkrævet']"
        ></q-input>
        <q-input
          class="col-12 q-mx-lg"
          outlined
          v-model="changeUser.lastName"
          label="Efternavn"
          :rules="[val => !!val || '* Påkrævet']"
        ></q-input>
        <q-input
          class="col-12 q-mx-lg"
          outlined
          v-model="changeUser.country"
          label="Land"
          :rules="[val => !!val || '* Påkrævet']"
        ></q-input>
        <q-input
          class="col-12 q-mx-lg"
          outlined
          type="number"
          v-model="changeUser.zipCode"
          label="Postnummer"
          :rules="[val => !!val || '* Påkrævet']"
        ></q-input>
        <q-input
          class="col-12 q-mx-lg"
          outlined
          v-model="changeUser.city"
          label="By"
          :rules="[val => !!val || '* Påkrævet']"
        ></q-input>
        <q-input
          class="col-12 q-mx-lg"
          outlined
          v-model="changeUser.address"
          label="Gade & nr"
          :rules="[val => !!val || '* Påkrævet']"
        ></q-input>
        <q-input
          class="col-12 q-mx-lg"
          outlined
          type="email"
          v-model="changeUser.email"
          label="Email"
          :rules="[val => !!val || '* Påkrævet']"
        ></q-input>
        <q-input
          class="col-12 q-mx-lg"
          outlined
          type="number"
          v-model="changeUser.phone"
          label="Telefon"
          :rules="[val => !!val || '* Påkrævet']"
        ></q-input>
        <q-select
          class="col-12 q-mx-lg"
          outlined
          v-model="changeUser.gender"
          :options="gender"
          label="Køn"
          :rules="[val => !!val || '* Påkrævet']"
        ></q-select>
        <q-card-actions align="center" class="q-pb-lg">
          <q-btn
            label="Ændr info"
            color="primary"
            v-close-popup
            @click="updateUser()"
          />
        </q-card-actions>
      </q-card>
    </q-dialog>
  </div>
</template>

<script>
export default {
  name: "ComponentName",
  data() {
    return {
      group: "",
      options: [
        {
          label: "Ejer af hingst",
          value: "owner"
        },
        {
          label: "Holder af hingst",
          value: "caretaker"
        }
      ],
      user: {
        firstName: "Rasputin",
        lastName: "Hansen",
        country: "Denmark",
        address: "Bøllegade 13",
        zipCode: 8700,
        city: "Horsens",
        phone: 12341231,
        email: "email@email.com",
        gender: "Mand"
      },
      changeUser: {
        firstName: "",
        lastName: "",
        country: "",
        address: "",
        zipCode: null,
        city: "",
        phone: null,
        email: "",
        gender: ""
      },
      alert: false,
      gender: ["Mand", "Kvinde", "Andet"]
    };
  },

  methods: {
    updateUser: function() {
      this.user = this.changeUser;
    }
  }
};
</script>

<style lang="scss" scoped></style>
