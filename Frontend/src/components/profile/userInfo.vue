<template>
  <div>
    <h1 class="text-h6 col-12 text-center">
      Personlige oplysninger
    </h1>
    <q-markup-table bordered square class="row col-12 col-md-4 q-mt-none">
      <tbody>
        <tr>
          <td class="text-weight-medium">Navn:</td>
          <td class="text-left">{{ user.firstName }} {{ user.lastName }}</td>
        </tr>
        <tr>
          <td class="text-weight-medium">Køn:</td>
          <td class="text-left">{{ user.gender }}</td>
        </tr>
        <tr>
          <td class="text-weight-medium">Gade/vej:</td>
          <td class="text-left">{{ user.address }}</td>
        </tr>
        <tr>
          <td class="text-weight-medium">Postnummer:</td>
          <td class="text-left">{{ user.zipCode }}</td>
        </tr>
        <tr>
          <td class="text-weight-medium">By:</td>
          <td class="text-left">{{ user.city }}</td>
        </tr>
        <tr>
          <td class="text-weight-medium">Land:</td>
          <td class="text-left">{{ user.country }}</td>
        </tr>
        <tr>
          <td class="text-weight-medium">Telefon:</td>
          <td class="text-left">{{ user.phone }}</td>
        </tr>
        <tr>
          <td class="text-weight-medium">Email:</td>
          <td class="text-left">{{ user.email }}</td>
        </tr>
      </tbody>
    </q-markup-table>

    <div class="flex justify-center q-mt-sm">
      <q-btn color="primary" label="Ret info" @click="changeInfo = true" />
    </div>

    <q-dialog class="dialog" v-model="changeInfo">
      <changeUserInfo
        class="dialog hide-scrollbar"
        :obj="user"
        @updateInfo="updateUserInfo"
      ></changeUserInfo>
    </q-dialog>
  </div>
</template>

<script>
import ChangeUserInfo from "components/profile/ChangeUserInfo";
export default {
  name: "UserInfo",

  components: {
    ChangeUserInfo
  },

  data() {
    return {
      changeInfo: false,
      user: {
        id: 0,
        firstName: "Lars",
        lastName: "Larsen",
        country: "Denmark",
        address: "Bøllegade 13",
        zipCode: 8700,
        city: "Horsens",
        phone: 12345678,
        email: "email@email.com",
        gender: "Mand"
      }
    };
  },

  methods: {
    updateUserInfo(user) {
      this.user = user;
    }
  }
};
</script>

<style lang="scss" scoped>
.dialog {
  width: 800px;
  max-width: 80vw;
}
</style>
