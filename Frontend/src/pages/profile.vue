<template>
  <q-page>
    <div class="text-h5 text-center q-mt-md text-weight-medium">
      Brugerprofil
    </div>
    <div class="row flex justify-between q-col-gutter-md q-mt-md">
      <div class="row col-12 col-md-6">
        <q-card class="flex justify-center row col-12 q-pa-none">
          <q-card-section class="row col-11">
            <userInfo class="col-12"></userInfo>
          </q-card-section>
        </q-card>
      </div>
      <div class="row col-12 col-md-6">
        <q-card class="flex justify-center row col-12 q-pa-none">
          <q-card-section class="row col-11">
            <horseList class="col-12"></horseList>
          </q-card-section>
        </q-card>
      </div>
    </div>
  </q-page>
</template>

<script>
import UserInfo from "components/profile/UserInfo";
import HorseList from "components/profile/HorseList";
export default {
  name: "Profile",

  components: {
    UserInfo,
    HorseList
  }
};
</script>

<style lang="scss" scoped>
.col-md-5 {
  width: 48% !important;
}
</style>
